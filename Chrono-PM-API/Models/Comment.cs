﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Chrono_PM_API.Models;

public record Comment
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; init; }
    [MaxLength(50)] public string Summary { get; init; } = string.Empty;

    [MaxLength(250)] public string Content { get; init; } = string.Empty;
    public DateTime CreatedAt { get; init; } = DateTime.Now;

    [Required(ErrorMessage = "AuthorId is required")]
    public string AuthorId { get; init; } = string.Empty;

    [Required(ErrorMessage = "IssueId is required")]
    public string IssueId { get; init; } = string.Empty;
}