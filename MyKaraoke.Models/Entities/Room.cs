using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MyKaraoke.Models.Enums;

namespace MyKaraoke.Models.Entities;

public class Room
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public required string Name { get; set; }

    [Required]
    [StringLength(20)]
    public required string Passcode { get; set; }

    [Required]
    public int HostId { get; set; }

    [ForeignKey("HostId")]
    public required User Host { get; set; }

    [Required]
    public RoomStatus Status { get; set; }

    [Required]
    public int MaxMembers { get; set; }

    [Required]
    public DateTime CreatedAt { get; set; }

    public int? CurrentSongId { get; set; }

    [ForeignKey("CurrentSongId")]
    public Song? CurrentSong { get; set; }

    public ICollection<User> Members { get; set; } = new List<User>();

}
