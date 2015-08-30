﻿using System.Diagnostics;
using System.Xml.Serialization;

namespace GedcomLibrary
{
  [DebuggerDisplay("{File}")]
  public class GedcomObject
  {
    [XmlElement("Form")]
    public GedcomValue Form { get; set; }
    [XmlElement("File")]
    public GedcomValue File { get; set; }
  }
}