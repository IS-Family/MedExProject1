CREATE TABLE [dbo].[DocExpirationDates]
(
	[DoctorID] INT NOT NULL PRIMARY KEY, 
    [MedicalLicenseExpirDate] SMALLDATETIME NULL, 
    [DEACertExpirDate] SMALLDATETIME NULL, 
    [PharmacyCertExpirDate] SMALLDATETIME NULL, 
    [BoardCertExpirDate] SMALLDATETIME NULL, 
    [HospConfLetterExpirDate] SMALLDATETIME NULL, 
    [CLIACertExpirDate] SMALLDATETIME NULL, 
    [ProfLiabilityInsExpirDate] SMALLDATETIME NULL, 
    [BusinessLicenseForPractExpirDate] SMALLDATETIME NULL, 
    [DriversLicenseExpirDate] SMALLDATETIME NULL
)
