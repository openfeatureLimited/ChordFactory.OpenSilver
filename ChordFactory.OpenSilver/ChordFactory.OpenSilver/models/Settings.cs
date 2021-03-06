﻿namespace ChordFactory.OpenSilver.models
{
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("settings")]
    public class Settings
    {
        //[PrimaryKey]
        public int Id { get; set; }

        public bool PlaySelection { get; set; }

        public bool ArpeggiateChord { get; set; }

        public string BlackKeySelectedScaleColour { get; set; }

        public string WhiteKeySelectedScaleColour { get; set; }

        public string WhiteKeySelectedFinderColour { get; set; }

        public string BlackKeySelectedFinderColour { get; set; }

        public string BlackKeySelectedChordColour { get; set; }

        public string WhiteKeySelectedChordColour { get; set; }

        public bool IsValid =>
            this.BlackKeySelectedChordColour != null
            && this.BlackKeySelectedScaleColour != null
            && this.WhiteKeySelectedChordColour != null
            && this.WhiteKeySelectedScaleColour != null;
    }
}