//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace iMoodFinalProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Age { get; set; }
        public string Occupation { get; set; }
    
        public virtual MoodResult MoodResult { get; set; }
        public virtual MoodResult MoodResult1 { get; set; }
    }
}
