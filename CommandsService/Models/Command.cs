using System.ComponentModel.DataAnnotations;

namespace CommandsService.Models
{
    public class Command
    {
        [Key]
        public required int Id { get; set; }
        public required string HowTo { get; set; }
        public required string CommandLine { get; set; }
        public required int PlatformId { get; set; }
        public Platform Platform { get; set; }
    }
}