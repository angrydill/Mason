﻿namespace Mason.IssueTracker.Contract
{
  public class CreateProjectArgs
  {
    public string Code { get; set; }

    public string Title { get; set; }

    public string Description { get; set; }
  }
}