using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Identifies a trunk group within an Enterprise Trunk where the service provider id is already known.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""b9c14e2d80e4e7749688ca13ba233b44:1858""}]")]
    public class EnterpriseTrunkTrunkGroupKey
    {

        private string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1858")]
        [MinLength(1)]
        [MaxLength(30)]
        public string GroupId
        {
            get => _groupId;
            set
            {
                GroupIdSpecified = true;
                _groupId = value;
            }
        }

        [XmlIgnore]
        protected bool GroupIdSpecified { get; set; }

        private string _trunkGroupName;

        [XmlElement(ElementName = "trunkGroupName", IsNullable = false, Namespace = "")]
        [Group(@"b9c14e2d80e4e7749688ca13ba233b44:1858")]
        [MinLength(1)]
        [MaxLength(30)]
        public string TrunkGroupName
        {
            get => _trunkGroupName;
            set
            {
                TrunkGroupNameSpecified = true;
                _trunkGroupName = value;
            }
        }

        [XmlIgnore]
        protected bool TrunkGroupNameSpecified { get; set; }

    }
}
