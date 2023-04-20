using Azure.Data.Tables;
using dyte_middleware.Models;
using dyte_middleware.Utils;
using Microsoft.AspNetCore.Mvc;

namespace dyte_middleware.Controllers
{
    public class ParticipantWebhookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost(Name = "CreateMeeting")]
        public async Task<IActionResult> Create(ParticipantWebhookResponse eventData)
        {
            if (eventData == null)
                return StatusCode(400);

            var tableClient = new TableClient(Globals.AzureStorageUri, Globals.AzureTableForMeetings);
            await tableClient.CreateIfNotExistsAsync();
            var entity = new TableEntity(eventData.meeting.sessionId, eventData.participant.customParticipantId)
            {
                {   "DisplayName", eventData.participant.userDisplayName }
            };

            return Created(string.Empty, entity);

        }
    }
}
