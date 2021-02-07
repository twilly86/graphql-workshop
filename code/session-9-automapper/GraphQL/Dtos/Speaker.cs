using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ConferencePlanner.GraphQL.Data
{
    public class SpeakerDto
    {
           public int Id { get; set; }

           [Required]
           [StringLength(200)]
           public string? Name { get; set; }

           [StringLength(4000)]
           public string? Bio { get; set; }

           [StringLength(1000)]
           public string? WebSite { get; set; }

           public ICollection<SessionSpeakerDto> SessionSpeakers { get; set; } = 
               new List<SessionSpeakerDto>();
       }
   }