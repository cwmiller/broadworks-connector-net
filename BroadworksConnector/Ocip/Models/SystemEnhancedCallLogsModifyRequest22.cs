using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the system level data associated with Enhanced Call Logs.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f6b3702edb5f67fa12c2c426d98657db:268""}]")]
    public class SystemEnhancedCallLogsModifyRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private int _maxNonPagedResponseSize;

        [XmlElement(ElementName = "maxNonPagedResponseSize", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f6b3702edb5f67fa12c2c426d98657db:268")]
        [MinInclusive(100)]
        [MaxInclusive(1000)]
        public int MaxNonPagedResponseSize
        {
            get => _maxNonPagedResponseSize;
            set
            {
                MaxNonPagedResponseSizeSpecified = true;
                _maxNonPagedResponseSize = value;
            }
        }

        [XmlIgnore]
        protected bool MaxNonPagedResponseSizeSpecified { get; set; }

        private string _eclQueryApplicationURL;

        [XmlElement(ElementName = "eclQueryApplicationURL", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f6b3702edb5f67fa12c2c426d98657db:268")]
        [MinLength(1)]
        [MaxLength(256)]
        public string EclQueryApplicationURL
        {
            get => _eclQueryApplicationURL;
            set
            {
                EclQueryApplicationURLSpecified = true;
                _eclQueryApplicationURL = value;
            }
        }

        [XmlIgnore]
        protected bool EclQueryApplicationURLSpecified { get; set; }

        private string _eclQueryDataRepositoryURL;

        [XmlElement(ElementName = "eclQueryDataRepositoryURL", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f6b3702edb5f67fa12c2c426d98657db:268")]
        [MinLength(1)]
        [MaxLength(256)]
        public string EclQueryDataRepositoryURL
        {
            get => _eclQueryDataRepositoryURL;
            set
            {
                EclQueryDataRepositoryURLSpecified = true;
                _eclQueryDataRepositoryURL = value;
            }
        }

        [XmlIgnore]
        protected bool EclQueryDataRepositoryURLSpecified { get; set; }

        private string _defaultSchema;

        [XmlElement(ElementName = "defaultSchema", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"f6b3702edb5f67fa12c2c426d98657db:268")]
        [MinLength(1)]
        [MaxLength(80)]
        public string DefaultSchema
        {
            get => _defaultSchema;
            set
            {
                DefaultSchemaSpecified = true;
                _defaultSchema = value;
            }
        }

        [XmlIgnore]
        protected bool DefaultSchemaSpecified { get; set; }

    }
}
