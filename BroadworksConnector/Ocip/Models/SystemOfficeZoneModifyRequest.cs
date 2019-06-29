using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify an existing Office Zone.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:12942""}]")]
    public class SystemOfficeZoneModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _officeZoneName;

        [XmlElement(ElementName = "officeZoneName", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:12942")]
        [MinLength(1)]
        [MaxLength(40)]
        public string OfficeZoneName
        {
            get => _officeZoneName;
            set
            {
                OfficeZoneNameSpecified = true;
                _officeZoneName = value;
            }
        }

        [XmlIgnore]
        protected bool OfficeZoneNameSpecified { get; set; }

        private string _newOfficeZoneName;

        [XmlElement(ElementName = "newOfficeZoneName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:12942")]
        [MinLength(1)]
        [MaxLength(40)]
        public string NewOfficeZoneName
        {
            get => _newOfficeZoneName;
            set
            {
                NewOfficeZoneNameSpecified = true;
                _newOfficeZoneName = value;
            }
        }

        [XmlIgnore]
        protected bool NewOfficeZoneNameSpecified { get; set; }

        private string _description;

        [XmlElement(ElementName = "description", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:12942")]
        [MinLength(1)]
        [MaxLength(80)]
        public string Description
        {
            get => _description;
            set
            {
                DescriptionSpecified = true;
                _description = value;
            }
        }

        [XmlIgnore]
        protected bool DescriptionSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ReplacementZoneList _replacementZoneList;

        [XmlElement(ElementName = "replacementZoneList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:12942")]
        public BroadWorksConnector.Ocip.Models.ReplacementZoneList ReplacementZoneList
        {
            get => _replacementZoneList;
            set
            {
                ReplacementZoneListSpecified = true;
                _replacementZoneList = value;
            }
        }

        [XmlIgnore]
        protected bool ReplacementZoneListSpecified { get; set; }

        private string _primaryZoneName;

        [XmlElement(ElementName = "primaryZoneName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:12942")]
        [MinLength(1)]
        [MaxLength(80)]
        public string PrimaryZoneName
        {
            get => _primaryZoneName;
            set
            {
                PrimaryZoneNameSpecified = true;
                _primaryZoneName = value;
            }
        }

        [XmlIgnore]
        protected bool PrimaryZoneNameSpecified { get; set; }

    }
}
