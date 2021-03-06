﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkflowCore.Interface;

namespace WorkflowCore.Models
{
    public class StepExecutionContext : IStepExecutionContext
    {
        public WorkflowInstance Workflow { get; set; }
        public WorkflowStep Step { get; set; }
        public object PersistenceData { get; set; }
    }
}
