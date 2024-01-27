using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to export Application Server addressing data, such as DNs, extensions, alias and user ids
    /// to a file so they can be uploaded to a Network Server.
    /// In XS data mode, response is sent without waiting for completion.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:10049""}]")]
    public class SystemExportAddressingDataRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _fileName;

        [XmlElement(ElementName = "fileName", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:10049")]
        [MinLength(1)]
        public string FileName
        {
            get => _fileName;
            set
            {
                FileNameSpecified = true;
                _fileName = value;
            }
        }

        [XmlIgnore]
        protected bool FileNameSpecified { get; set; }

    }
}
