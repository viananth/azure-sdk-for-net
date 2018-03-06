::
:: Microsoft Azure SDK for Net - Generate library code
:: Copyright (C) Microsoft Corporation. All Rights Reserved.
::


@echo off
call %~dp0..\..\..\..\tools\generate.cmd azsadmin/resource-manager/infrastructureinsights latest deathly809 azs.infrastructureinsights.admin azure-rest-api-specs %CD%
rd Generated /S /Q
move InfrastructureInsights\InfrastructureInsights.Admin\Generated .
rd InfrastructureInsights /S /Q