--Step 01
CREATE TABLE [dbo].[Vendor](
	[Vendor_Id] [nvarchar](50) NULL,
	[Vendor_Name] [varchar](150) NULL,
	[Company] [varchar](50) NULL,
	[Address] [varchar](250) NULL,
	[Contact] [nvarchar](50) NULL,
	[Tin_No] [nvarchar](50) NULL,
	[Gst_No] [nvarchar](50) NULL
) ON [PRIMARY]


--Step 02
INSERT [dbo].[Vendor] ([Vendor_Id], [Vendor_Name], [Company], [Address], [Contact], [Tin_No], [Gst_No]) VALUES (N'ID0001', N'sarayu', N'Sun Gold', N'vnb
Vellore', N'1234567890', N'333333333333333', N'333333333333333333')
GO
INSERT [dbo].[Vendor] ([Vendor_Id], [Vendor_Name], [Company], [Address], [Contact], [Tin_No], [Gst_No]) VALUES (N'ID0002', N'Ganesh', N'ABC & Co.', N'vnb
vellroe', N'987655433323', N'sdfsd', N'dfdf')
GO
INSERT [dbo].[Vendor] ([Vendor_Id], [Vendor_Name], [Company], [Address], [Contact], [Tin_No], [Gst_No]) VALUES (N'ID0003', N'Atthaullah', N'A to Z Store', N'Mosque Street,
Newtown,
Vaniyambadi', N'234234234', N'35456', N'e54564')
GO
INSERT [dbo].[Vendor] ([Vendor_Id], [Vendor_Name], [Company], [Address], [Contact], [Tin_No], [Gst_No]) VALUES (N'ID0004', N'Kathir', N'Kathir & Co', N'werer
etrert
', N'2343543534', N'gdfgsdfdsfg', N'sdsfdfg')


-- Step 03
Create function [dbo].[VendorID]() 
returns char(6) 
as 
begin 
	DECLARE @lastval INT 
	SET @lastval = (select MAX(Cast(right(Vendor_Id,4) as int))  from Vendor) 
	if @lastval is null set @lastval = 0 
	Return 'ID' + right('0000' + convert(varchar(10),(@lastval + 1)),4) 
end