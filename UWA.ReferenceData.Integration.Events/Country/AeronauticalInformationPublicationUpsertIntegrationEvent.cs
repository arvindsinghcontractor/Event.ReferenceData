namespace UWA.ReferenceData.Integration.Events.Country
{
    public class AeronauticalInformationPublicationUpsertIntegrationEvent
    {
        public int AeronauticalInformationPublicationId { get; set; }
        public string AIPLink { get; set; }
        public string AIPUsername { get; set; }
        public string AIPPassword { get; set; }
        public string Description { get; set; }
    }
}
