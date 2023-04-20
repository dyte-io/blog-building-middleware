
using System.Text.Json.Serialization;

public class ActiveSessionResponse
{
    [JsonPropertyName("success")]
    public bool Success { get; set; }
    [JsonPropertyName("data")]
    public ActiveSessionResponseData Data { get; set; }
}

public class ActiveSessionResponseData
{
    [JsonPropertyName("id")]
    public string ActiveSessionId { get; set; }
    [JsonPropertyName("associated_id")]
    public string MeetingId { get; set; }
    [JsonPropertyName("type")]
    public string MeetingType { get; set; }
    [JsonPropertyName("meeting_display_name")]
    public string MeetingTitle { get; set; }
    [JsonPropertyName("status")]
    public string Status { get; set; }
    [JsonPropertyName("live_participants")]
    public int CurrentNumberOfParticipants { get; set; }
    [JsonPropertyName("max_concurrent_participants")]
    public int MaximumNumberOfParticipants { get; set; }
    [JsonPropertyName("recording_status")]
    public string RecordingStatus { get; set; }
    [JsonPropertyName("total_participants")]
    public int TotalNumberOfParticipants { get; set; }
    [JsonPropertyName("minutes_consumed")]
    public float MinutesConsumedInSession { get; set; }
    [JsonPropertyName("organization_id")]
    public string OrganizationId { get; set; }
    [JsonPropertyName("started_at")]
    public DateTime StartedOn { get; set; }
    [JsonPropertyName("ended_at")]
    public object EndedOn { get; set; }
    [JsonPropertyName("created_at")]
    public DateTime CreatedOn { get; set; }
    [JsonPropertyName("updated_at")]
    public DateTime UpdatedOn { get; set; }
    [JsonPropertyName("meta")]
    public Meta Meta { get; set; }
}

public class Meta
{
    public string room_name { get; set; }
}
