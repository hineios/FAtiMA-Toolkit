﻿using System;
using Conditions.DTOs;
using WellFormedNames;
using RolePlayCharacter;

namespace WorldModel.DTOs
{
    /// <summary>
    /// Data Type Object Class for the representation of an Appraisal Rule.
    /// Appraisal rules determines how emotions are generated based on perceived events.
    /// </summary>
    [Serializable]
    public class EffectDTO 
    {
	
		public Guid Id { get; set; }
      
        public Name PropertyName { get; set; }
        
        public Name NewValue { get; set; }

        public Name ResponsibleAgent { get; set; } 

        public Name ObserverAgent { get; set; }

        public Name ToPropertyChangeEvent()
        {
            return EventHelper.PropertyChange(PropertyName.ToString(), NewValue.ToString(), ResponsibleAgent.ToString());
        }
    }
}
