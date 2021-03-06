function New-IamPrivilegeList {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Int32]]
        ${Count},
        [Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[intersight.Model.IamPrivilege[]]]
        ${Results}
    )

    Process {
        'Creating object: intersight.Model.IamPrivilegeList' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        New-Object -TypeName intersight.Model.IamPrivilegeList -ArgumentList @(
            ${Count},
            ${Results}
        )
    }
}
