﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GedcomLibrary
{
  /// <summary>
  /// Represents a GEDCOM file.
  /// </summary>
  [XmlRoot("GedcomFile")]
  public class GedcomFile
  {
    [XmlElement("Head")]
    public GedcomHead Head { get; set; }
    [XmlElement("Individual")]
    public List<GedcomIndividual> Individuals { get; set; }
    [XmlElement("Family")]
    public List<GedcomFamily> Families { get; set; }
  }
}