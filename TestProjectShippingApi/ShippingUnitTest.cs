namespace TestProjectShippingApi
{
    using FedExAPI;
    using System.Diagnostics;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    public class ShippingUnitTest
    {
        [Fact]
        public void Deserialize()
        {
            string jsonstring = """
			{
			    "labelResponseOptions": "URL_ONLY",
			    "accountNumber": {
			        "value": "653286864",
			        "Comment_": "Only this account is enabled for PRIORITY ALERT"
			    },
			    "_Comment_": "---------- SHIPMENT SECTION ----------",
			    "requestedShipment": {
			        "shipDatestamp": "2022-08-25",
			        "pickupType": "CONTACT_FEDEX_TO_SCHEDULE",
			        "serviceType": "FEDEX_INTERNATIONAL_PRIORITY",
			        "packagingType": "YOUR_PACKAGING",
			        "blockInsightVisibility": false,
			        "labelSpecification": {
			            "imageType": "PDF",
			            "labelStockType": "PAPER_85X11_TOP_HALF_LABEL"
			        },
			        "shipper": {
			            "contact": {
			                "personName": "Sender Contact Name",
			                "companyName": "Sender Company Name",
			                "emailAddress": "sender@shipper.it",
			                "phoneNumber": "0221881"
			            },
			            "address": {
			                "streetLines": [
			                    "SENDER ADDRESS LINE 1",
			                    "SENDER ADDRESS LINE 2",
			                    "SENDER ADDRESS LINE 3"
			                ],
			                "city": "Sender City Name",
			                "postalCode": "20128",
			                "countryCode": "IT",
			                "residential": false
			            },
			            "tins": [
			                {
			                    "number": "IT12345678901",
			                    "tinType": "BUSINESS_UNION"
			                }
			            ]
			        },
			        "recipients": [
			            {
			                "contact": {
			                    "personName": "Recipient Contact Name",
			                    "companyName": "Recipient Company Name",
			                    "emailAddress": "recipient@recipient.com",
			                    "phoneNumber": "1222222222"
			                },
			                "address": {
			                    "streetLines": [
			                        "RECIPIENT ADDRESS LINE 1",
			                        "RECIPIENT ADDRESS LINE 2",
			                        "RECIPIENT ADDRESS LINE 3"
			                    ],
			                    "city": "New York",
			                    "stateOrProvinceCode": "NY",
			                    "postalCode": "10010",
			                    "countryCode": "US",
			                    "residential": true
			                }
			            }
			        ],
			        "shippingChargesPayment": {
			            "paymentType": "SENDER"
			        },
			        "customsClearanceDetail": {
			            "dutiesPayment": {
			                "paymentType": "SENDER"
			            },
			            "isDocumentOnly": false,
			            "totalCustomsValue": {
			                "amount": "10.00",
			                "currency": "EUR"
			            },
			            "_Comment_": "---------- COMMODITIES SECTION ----------",
			            "commodities": [
			                {
			                    "description": "COMMODITY DESCRIPTION 1",
			                    "countryOfManufacture": "IT",
			                    "harmonizedCode": "1234567890",
			                    "weight": {
			                        "units": "KG",
			                        "value": "10.5"
			                    },
			                    "quantity": "1",
			                    "quantityUnits": "PCS",
			                    "unitPrice": {
			                        "amount": "10.00",
			                        "currency": "EUR"
			                    },
			                    "customsValue": {
			                        "amount": "10.00",
			                        "currency": "EUR"
			                    }
			                }
			            ]
			        },
			        "_Comment_": "---------- PACKAGE SECTION ----------",
			        "totalPackageCount": "1",
			        "requestedPackageLineItems": [
			            {
			                "_Comment_": " groupPackageCount designates the number of identical packages of the specified weight + dimensions in the shipment",
			                "groupPackageCount": "1",
			                "packageSpecialServices": {
			                    "specialServiceTypes": [
			                        "PRIORITY_ALERT"
			                    ],
			                    "priorityAlertDetail": {
			                        "enhancementTypes": [
			                            "PRIORITY_ALERT_PLUS"
			                        ],
			                        "content": [
			                            "My FPA Content"
			                        ]
			                    }
			                },
			                "weight": {
			                    "units": "KG",
			                    "value": "10.5"
			                },
			                "dimensions": {
			                    "length": 20,
			                    "width": 20,
			                    "height": 20,
			                    "units": "CM"
			                }
			            }
			        ]
			    }
			}
			""";
			JsonSerializerOptions options = new() { NumberHandling = JsonNumberHandling.AllowReadingFromString, DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull, WriteIndented = true, PropertyNameCaseInsensitive = true, PropertyNamingPolicy = JsonNamingPolicy.CamelCase, Converters = { new JsonStringEnumConverter() } };
			options.Converters.Add(new CustomJsonConverterForNullableDateTime());
            CreateShipmentRootobject? obj = JsonSerializer.Deserialize<CreateShipmentRootobject>(jsonstring, options);
            Assert.NotNull(obj);
            string newjsonstring = JsonSerializer.Serialize(obj, options);
            Console.WriteLine(newjsonstring);
        }

        private class CustomJsonConverterForNullableDateTime : JsonConverter<DateTime?>
        {
            public override DateTime? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                Debug.Assert(typeToConvert == typeof(DateTime?));
                return reader.GetString() == "" ? null : reader.GetDateTime();
            }

            public override void Write(Utf8JsonWriter writer, DateTime? value, JsonSerializerOptions options)
            {
                if (!value.HasValue)
                {
                    writer.WriteStringValue("");
                }
                else
                {
                    writer.WriteStringValue(value.Value);
                }
            }
        }
    }
}