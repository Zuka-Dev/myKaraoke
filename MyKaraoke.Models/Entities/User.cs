using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyKaraoke.Models.Entities;

public class User
{
    public int Id { get; set; }

    public string Username { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public required byte[] PasswordHash { get; set; }

    public required byte[] PasswordSalt { get; set; }

    public DateTime CreatedAt { get; set; }


    public int? RoomId { get; set; }

    [ForeignKey("RoomId")]
    public virtual Room? Room { get; set; }
}
