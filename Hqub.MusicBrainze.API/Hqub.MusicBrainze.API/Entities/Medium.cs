﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Hqub.MusicBrainze.API.Entities
{
    [XmlRoot("medium")]
    public class Medium
    {
        [XmlElement("format")]
        public string Format { get; set; }

        [XmlElement("disc-list")]
        public DiskList Disks { get; set; }

        [XmlElement("track-list")]
        public TrackList Tracks { get; set; }
    }

    [XmlRoot("disk-list")]
    public class DiskList 
    {
        [XmlAttribute("count")]
        public int Count { get; set; }
    }

    [XmlRoot("track-list")]
    public class TrackList
    {
        [XmlAttribute("count")]
        public int Count { get; set; }
    }
}
