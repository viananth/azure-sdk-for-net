::
:: Microsoft Azure SDK for Net - Generate library code
:: Copyright (C) Microsoft Corporation. All Rights Reserved.
::

@echo off
call %~dp0..\..\..\..\tools\generate.cmd azsadmin/resource-manager/update latest deathly809 azs.update.admin azure-rest-api-specs %CD%
rd /S /Q Generated
move Update\Update.Admin\Generated .
rd /S /Q Update

