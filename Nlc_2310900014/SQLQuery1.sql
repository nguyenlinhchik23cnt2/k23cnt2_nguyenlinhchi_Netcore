CREATE TABLE NlcEmployee (
    nlcEmpId INT PRIMARY KEY,
    nlcEmpName NVARCHAR(100),
    nlcEmpLevel NVARCHAR(50),
	NlcEmpStartDate DATETIME,
	nlcEmpStatus BIT
);


INSERT INTO NlcEmployee (nlcEmpId, nlcEmpName, nlcEmpLevel, nlcEmpStartDate, nlcEmpStatus)
VALUES
(1, N'Nguyễn Linh Chi ', N'Senior', '2005-01-24', 1),
(2, N'Trần Thị B', N'Junior', '2023-06-20', 1),
(3, N'Lê Văn C', N'Intern', '2024-03-01', 0),
(4, N'Phạm Thị D', N'Mid', '2021-11-10', 1),
(5, N'Hoàng Văn E', N'Senior', '2020-08-25', 0);
