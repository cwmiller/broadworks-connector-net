using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemPerformanceMeasurementReportingGetRequest22.
        /// <see cref="SystemPerformanceMeasurementReportingGetRequest22"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemPerformanceMeasurementReportingGetResponse22 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        public bool IsActive {
            get => _isActive;
            set {
                IsActiveSpecified = true;
                _isActive = value;
            }
        }

        [XmlIgnore]
        public bool IsActiveSpecified { get; set; }
        
        private int _reportingInterval;

        [XmlElement(ElementName = "reportingInterval", IsNullable = false, Namespace = "")]
        public int ReportingInterval {
            get => _reportingInterval;
            set {
                ReportingIntervalSpecified = true;
                _reportingInterval = value;
            }
        }

        [XmlIgnore]
        public bool ReportingIntervalSpecified { get; set; }
        
        private bool _resetMeasurementsAfterEachReport;

        [XmlElement(ElementName = "resetMeasurementsAfterEachReport", IsNullable = false, Namespace = "")]
        public bool ResetMeasurementsAfterEachReport {
            get => _resetMeasurementsAfterEachReport;
            set {
                ResetMeasurementsAfterEachReportSpecified = true;
                _resetMeasurementsAfterEachReport = value;
            }
        }

        [XmlIgnore]
        public bool ResetMeasurementsAfterEachReportSpecified { get; set; }
        
        private bool _reportEnterprise;

        [XmlElement(ElementName = "reportEnterprise", IsNullable = false, Namespace = "")]
        public bool ReportEnterprise {
            get => _reportEnterprise;
            set {
                ReportEnterpriseSpecified = true;
                _reportEnterprise = value;
            }
        }

        [XmlIgnore]
        public bool ReportEnterpriseSpecified { get; set; }
        
        private bool _reportServiceProvider;

        [XmlElement(ElementName = "reportServiceProvider", IsNullable = false, Namespace = "")]
        public bool ReportServiceProvider {
            get => _reportServiceProvider;
            set {
                ReportServiceProviderSpecified = true;
                _reportServiceProvider = value;
            }
        }

        [XmlIgnore]
        public bool ReportServiceProviderSpecified { get; set; }
        
        private bool _reportDevice;

        [XmlElement(ElementName = "reportDevice", IsNullable = false, Namespace = "")]
        public bool ReportDevice {
            get => _reportDevice;
            set {
                ReportDeviceSpecified = true;
                _reportDevice = value;
            }
        }

        [XmlIgnore]
        public bool ReportDeviceSpecified { get; set; }
        
        private bool _reportTable;

        [XmlElement(ElementName = "reportTable", IsNullable = false, Namespace = "")]
        public bool ReportTable {
            get => _reportTable;
            set {
                ReportTableSpecified = true;
                _reportTable = value;
            }
        }

        [XmlIgnore]
        public bool ReportTableSpecified { get; set; }
        
    }
}
