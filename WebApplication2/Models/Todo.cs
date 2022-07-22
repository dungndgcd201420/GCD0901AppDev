﻿using System;
using WebApplication2.Enums;

namespace WebApplication2.Models
{
  public class Todo
  {
    public int Id { get; set; }
    public string Description   { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public TodoStatus Status { get; set; } = TodoStatus.Todo;
  }
}