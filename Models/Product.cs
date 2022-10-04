﻿using System.ComponentModel.DataAnnotations;
using WebStock.Models.Entities;

namespace WebStock.Models;

public class Product : Entity
{
    [Required(ErrorMessage = "The field '{0}' is required")]
    [StringLength(100, ErrorMessage = "The field '{0}' must be between {2} and {1} characters", MinimumLength = 3)]
    public string Name { get; set; }

    [Required(ErrorMessage = "The field '{0}' is required")]
    [StringLength(35, ErrorMessage = "The field '{0}' must be between {2} and {1} characters", MinimumLength = 3)]
    public string CodeBar { get; set; }

    [Required(ErrorMessage = "The field '{0}' is required")]
    [StringLength(50, ErrorMessage = "The field '{0}' must be between {2} and {1} characters", MinimumLength = 1)]
    public string ProductCode { get; set; }

    [StringLength(1000, ErrorMessage = "The field '{0}' must be even {1} characters")]
    public string? Description { get; set; }

    [Required]
    public Supplier Supplier { get; set; }
}