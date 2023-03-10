namespace FedExAPI
{
    public class ReturnShipmentDetail
    {
        public ReturnEmailDetail? ReturnEmailDetail { get; set; }
        public Rma? Rma { get; set; }
        public ReturnAssociationDetail? ReturnAssociationDetail { get; set; }
        public EnumReturnType? ReturnType { get; set; }
    }
}