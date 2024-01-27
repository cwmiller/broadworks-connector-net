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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""090e91b2d78e873f5d76a2f16af08d3a:1936""}]")]
    public class EnterpriseTrunkTrunkGroupKey
    {

        protected string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        [Group(@"090e91b2d78e873f5d76a2f16af08d3a:1936")]
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

        protected string _trunkGroupName;

        [XmlElement(ElementName = "trunkGroupName", IsNullable = false, Namespace = "")]
        [Group(@"090e91b2d78e873f5d76a2f16af08d3a:1936")]
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
