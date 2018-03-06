::
:: Microsoft Azure SDK for Net - Generate library code
:: Copyright (C) Microsoft Corporation. All Rights Reserved.
::

@echo off
call %~dp0..\..\..\..\tools\generate.cmd azsadmin/resource-manager/storage latest deathly809 azs.storage.admin azure-rest-api-specs %CD%
rd Generated /S /Q
move Storage\Storage.Admin\Generated .
rd Storage /S /Q