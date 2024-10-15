﻿namespace TaskManagerAPI.Models;

public class TaskItem
{
    public int Id { get; set; } 
    public string Title { get; set; } 
    public string Description { get; set; } 
    public bool Status { get; set; }
    public string UserId { get; set; } 
}