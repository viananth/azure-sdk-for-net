@echo off 

set ServicePrincipal=a43388a5-2ea1-42ce-9262-95a25f9886f4
set ServicePrincipalSecret=User@123
set SubscriptionId=0af9c33b-f7ac-4161-add5-17b2f0b6a669
set AADTenant=1e64bce5-9f3b-4add-8be8-e550e05014d0

rem Playback or Record
set HttpRecorderMode=Record
set AADTokenAudienceUri=https://adminmanagement.azurestackci15.onmicrosoft.com/0e85323a-bbfb-472b-b5c5-eea2af467dea
set AADAuthEndpoint=https://login.windows.net/
set BaseUri=https://adminmanagement.local.azurestack.external
set ManagementResource=https://adminmanagement.azurestackci15.onmicrosoft.com/0e85323a-bbfb-472b-b5c5-eea2af467dea

set TEST_CSM_ORGID_AUTHENTICATION=SubscriptionId=%SubscriptionId%;AADTenant=%AADTenant%;HttpRecorderMode=%HttpRecorderMode%;AADTokenAudienceUri=%AADTokenAudienceUri%;BaseUri=%BaseUri%;AADAuthEndpoint=%AADAuthEndpoint%;ServicePrincipal=%ServicePrincipal%;password=%ServicePrincipalSecret%;ManagementResource=%ManagementResource%;password=%ServicePrincipalSecret%
set AZURE_TEST_MODE=%HttpRecorderMode%