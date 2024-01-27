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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:9750""}]")]
    public class SystemConfigurableFileSystemGetResponse23ProtocolFile
    {

        protected bool _replicated;

        [XmlElement(ElementName = "replicated", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:9750")]
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
        protected bool ReplicatedSpecified { get; set; }

    }
}
