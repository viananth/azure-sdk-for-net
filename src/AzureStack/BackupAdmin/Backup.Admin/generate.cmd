::
:: Microsoft Azure SDK for Net - Generate library code
:: Copyright (C) Microsoft Corporation. All Rights Reserved.
::

@echo off
call %~dp0..\..\..\..\tools\generate.cmd azsadmin/resource-manager/backup latest deathly809 azs.backup.admin azure-rest-api-specs %CD%
rd Generated /S /Q
move Backup\Backup.Admin\Generated .
rd Backup /S /Q