using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemStirShakenCallerIdDispositionMappingModifyRequest.
    /// Contains a table of Caller Id Disposition mapping.
    /// The column headings are: "Verstat", "Attestation", "Disposition".
    /// <see cref="SystemStirShakenCallerIdDispositionMappingModifyRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:18351""}]")]
    public class SystemStirShakenCallerIdDispositionMappingGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _callerIdDispositionMappingTable;

        [XmlElement(ElementName = "callerIdDispositionMappingTable", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:18351")]
        public BroadWorksConnector.Ocip.Models.C.OCITable CallerIdDispositionMappingTable
        {
            get => _callerIdDispositionMappingTable;
            set
            {
                CallerIdDispositionMappingTableSpecified = true;
                _callerIdDispositionMappingTable = value;
            }
        }

        [XmlIgnore]
        protected bool CallerIdDispositionMappingTableSpecified { get; set; }

    }
}
