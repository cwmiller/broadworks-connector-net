using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:6320""}]")]
    public class SystemConfigurableFileSystemModifyRequestProtocolFile
    {

        private bool _replicated;

        [XmlElement(ElementName = "replicated", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:6320")]
        public bool Replicated
        {
            get => _replicated;
            set
            {
                ReplicatedSpecified = true;
                _replicated = value;
            }
        }

        [XmlIgnore]
        public bool ReplicatedSpecified { get; set; }

    }
}
