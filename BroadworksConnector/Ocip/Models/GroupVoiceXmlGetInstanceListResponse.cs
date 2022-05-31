using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupVoiceXmlGetInstanceListRequest.
    /// Contains a table with column headings:
    /// "Service User Id", "Name", "Phone Number", "Extension", "Department", "Is Active".
    /// The column values for "Is Active" can either be true, or false.
    /// <see cref="GroupVoiceXmlGetInstanceListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""0639a23b2e14be05c11ead49c23bd0bd:106""}]")]
    public class GroupVoiceXmlGetInstanceListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _voiceXmlTable;

        [XmlElement(ElementName = "voiceXmlTable", IsNullable = false, Namespace = "")]
        [Group(@"0639a23b2e14be05c11ead49c23bd0bd:106")]
        public BroadWorksConnector.Ocip.Models.C.OCITable VoiceXmlTable
        {
            get => _voiceXmlTable;
            set
            {
                VoiceXmlTableSpecified = true;
                _voiceXmlTable = value;
            }
        }

        [XmlIgnore]
        protected bool VoiceXmlTableSpecified { get; set; }

    }
}
