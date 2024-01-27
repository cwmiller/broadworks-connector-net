using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemDeviceFamilyImportDryRunRequest.
    /// <see cref="SystemDeviceFamilyImportDryRunRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:7662""}]")]
    public class SystemDeviceFamilyImportDryRunResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _file;

        [XmlElement(ElementName = "file", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:7662")]
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

        protected bool _differenceFound;

        [XmlElement(ElementName = "differenceFound", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:7662")]
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
