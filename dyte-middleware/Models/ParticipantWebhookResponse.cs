using System.Text.Json.Serialization;

namespace dyte_middleware.Models
{
    public class ParticipantWebhookResponse
    {
        public string _event { get; set; }
        [JsonPropertyName("meeting")]
        public MeetingFromWebhook meeting { get; set; }
        public Participant participant { get; set; }
    }

    public class MeetingFromWebhook
    {
        public string id { get; set; }
        public string sessionId { get; set; }
        public string title { get; set; }
        public string status { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime startedAt { get; set; }
        public Organizedby organizedBy { get; set; }
    }

    public class Organizedby
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Participant
    {
        public string peerId { get; set; }
        public string userDisplayName { get; set; }
        public string customParticipantId { get; set; }
        public DateTime joinedAt { get; set; }
    }
}
