function Invoke-HyperflexServerFirmwareVersionApiHyperflexServerFirmwareVersionsGet {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [Boolean]
        ${$count},
        [Parameter(Position = 1, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [String]
        ${$inlinecount},
        [Parameter(Position = 2, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [Int32]
        ${$top},
        [Parameter(Position = 3, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [Int32]
        ${$skip},
        [Parameter(Position = 4, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [String]
        ${$filter},
        [Parameter(Position = 5, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [String]
        ${$select},
        [Parameter(Position = 6, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [String]
        ${$orderby},
        [Parameter(Position = 7, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [String]
        ${$expand},
        [Parameter(Position = 8, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [String]
        ${$apply},
        [Parameter(Position = 9, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $false)]
        [String]
        ${at}
    )

    Process {
        'Calling method: HyperflexServerFirmwareVersionApi-HyperflexServerFirmwareVersionsGet' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $Script:HyperflexServerFirmwareVersionApi.HyperflexServerFirmwareVersionsGet(
            ${$count},
            ${$inlinecount},
            ${$top},
            ${$skip},
            ${$filter},
            ${$select},
            ${$orderby},
            ${$expand},
            ${$apply},
            ${at}
        )
    }
}

function Invoke-HyperflexServerFirmwareVersionApiHyperflexServerFirmwareVersionsMoidDelete {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $true)]
        [String]
        ${moid}
    )

    Process {
        'Calling method: HyperflexServerFirmwareVersionApi-HyperflexServerFirmwareVersionsMoidDelete' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $Script:HyperflexServerFirmwareVersionApi.HyperflexServerFirmwareVersionsMoidDelete(
            ${moid}
        )
    }
}

function Invoke-HyperflexServerFirmwareVersionApiHyperflexServerFirmwareVersionsMoidGet {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $true)]
        [String]
        ${moid}
    )

    Process {
        'Calling method: HyperflexServerFirmwareVersionApi-HyperflexServerFirmwareVersionsMoidGet' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $Script:HyperflexServerFirmwareVersionApi.HyperflexServerFirmwareVersionsMoidGet(
            ${moid}
        )
    }
}

function Invoke-HyperflexServerFirmwareVersionApiHyperflexServerFirmwareVersionsMoidPatch {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $true)]
        [String]
        ${moid},
        [Parameter(Position = 1, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $true)]
        [intersight.Model.HyperflexServerFirmwareVersion]
        ${body}
    )

    Process {
        'Calling method: HyperflexServerFirmwareVersionApi-HyperflexServerFirmwareVersionsMoidPatch' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $Script:HyperflexServerFirmwareVersionApi.HyperflexServerFirmwareVersionsMoidPatch(
            ${moid},
            ${body}
        )
    }
}

function Invoke-HyperflexServerFirmwareVersionApiHyperflexServerFirmwareVersionsMoidPost {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $true)]
        [String]
        ${moid},
        [Parameter(Position = 1, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $true)]
        [intersight.Model.HyperflexServerFirmwareVersion]
        ${body}
    )

    Process {
        'Calling method: HyperflexServerFirmwareVersionApi-HyperflexServerFirmwareVersionsMoidPost' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $Script:HyperflexServerFirmwareVersionApi.HyperflexServerFirmwareVersionsMoidPost(
            ${moid},
            ${body}
        )
    }
}

function Invoke-HyperflexServerFirmwareVersionApiHyperflexServerFirmwareVersionsPost {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $true)]
        [intersight.Model.HyperflexServerFirmwareVersion]
        ${body}
    )

    Process {
        'Calling method: HyperflexServerFirmwareVersionApi-HyperflexServerFirmwareVersionsPost' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $Script:HyperflexServerFirmwareVersionApi.HyperflexServerFirmwareVersionsPost(
            ${body}
        )
    }
}

