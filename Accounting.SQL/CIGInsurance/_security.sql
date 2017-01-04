set QUOTED_IDENTIFIER OFF

use [IntermedCO]
go 

exec sp_msforeachtable @command1="print '? Constraints disabled'", @command2="alter table ? nocheck constraint all"
exec sp_msforeachtable @command1="print '? Triggers disabled'", @command2="alter table ? disable trigger all"

delete from [dbs].[Forms]
DBCC CHECKIDENT ('dbs.Forms', RESEED, 0)
insert into [dbs].[Forms] select * from [Security].[dbs].[Forms]

delete from [dbs].[groups]
DBCC CHECKIDENT ('dbs.groups', RESEED, 0)
insert into [dbs].[groups] select * from [Security].[dbs].[groups]

delete from [dbs].[GroupRoles]
DBCC CHECKIDENT ('dbs.GroupRoles', RESEED, 0)
insert into [dbs].[GroupRoles] select * from [Security].[dbs].[GroupRoles]

delete from [dbs].[Departments]
DBCC CHECKIDENT ('dbs.Departments', RESEED, 0)
insert into [dbs].[Departments] select * from [Security].[dbs].[Departments]

delete from [dbs].[UserRoles]
DBCC CHECKIDENT ('dbs.UserRoles', RESEED, 0)
insert into [dbs].[UserRoles] select * from [Security].[dbs].[UserRoles]

delete from [dbs].[Users]
DBCC CHECKIDENT ('dbs.Users', RESEED, 0)
insert into [dbs].[Users] select * from [Security].[dbs].[Users]

exec sp_msforeachtable @command1="print '? Triggers enabled'", @command2="alter table ? enable trigger all"
exec sp_msforeachtable @command1="print '? enabled'", @command2="alter table ? check constraint all"
