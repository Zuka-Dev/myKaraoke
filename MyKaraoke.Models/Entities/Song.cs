using System;
using System.ComponentModel.DataAnnotations;

namespace MyKaraoke.Models.Entities;

public class Song
{
    //     Id(PK, int, auto-increment)
    // Title(varchar(200))
    // Artist(varchar(200))
    // Duration(int, in seconds)
    // ExternalApiId(varchar(100), for reference to music API)
    [Key]
    public int Id { get; set; }

    public string? Title { get; set; }
    public string? Artiste { get; set; }
    [Required]
    public int Duration { get; set; } //In Seconds
    public int ExternalApiId { get; set; }
}
