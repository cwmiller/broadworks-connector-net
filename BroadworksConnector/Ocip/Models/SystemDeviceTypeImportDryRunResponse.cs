using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemDeviceTypeImportDryRunRequest.
    /// <see cref="SystemDeviceTypeImportDryRunRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:8832""}]")]
    public class SystemDeviceTypeImportDryRunResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _file;

        [XmlElement(ElementName = "file", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:8832")]
        [MinLength(1)]
        [MaxLength(256)]
        public string File
        {
            get => _file;
            set
            {
                FileSpecified = true;
                _file = value;
            }
        }

        [XmlIgnore]
        protected bool FileSpecified { get; set; }

        private bool _differenceFound;

        [XmlElement(ElementName = "differenceFound", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:8832")]
        public bool DifferenceFound
        {
            get => _differenceFound;
            set
            {
                DifferenceFoundSpecified = true;
                _differenceFound = value;
            }
        }

        [XmlIgnore]
        protected bool DifferenceFoundSpecified { get; set; }

    }
}
