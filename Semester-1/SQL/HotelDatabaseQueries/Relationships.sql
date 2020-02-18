ALTER TABLE PhoneInfo
ADD CONSTRAINT FK_PhoneInfo_PersonalInfo
FOREIGN KEY ([PersonalInfoId]) REFERENCES PersonalInfo([Id]);

ALTER TABLE PhoneTags
ADD CONSTRAINT FK_PhoneTags_PhoneInfo
FOREIGN KEY ([PhoneId]) REFERENCES PhoneInfo([Id]);

ALTER TABLE AddressTags
ADD CONSTRAINT FK_AddressTags_Addresses
FOREIGN KEY ([AddressId]) REFERENCES Addresses([Id]);

ALTER TABLE Addresses
ADD CONSTRAINT FK_Addresses_PersonalInfo
FOREIGN KEY ([PersonalInfoId]) REFERENCES PersonalInfo([Id]);

ALTER TABLE ReserveInfo
ADD CONSTRAINT FK_ReserveInfo_PersonalInfo
FOREIGN KEY ([PersonId]) REFERENCES PersonalInfo([Id]);

ALTER TABLE ReserveInfo
ADD CONSTRAINT FK_ReserveInfo_RoomInfo
FOREIGN KEY ([RoomId]) REFERENCES RoomInfo([Id]);