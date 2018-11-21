function Invoke-HyperflexFeatureLimitExternalApiHyperflexFeatureLimitExternalsGet {
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
        'Calling method: HyperflexFeatureLimitExternalApi-HyperflexFeatureLimitExternalsGet' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $Script:HyperflexFeatureLimitExternalApi.HyperflexFeatureLimitExternalsGet(
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

function Invoke-HyperflexFeatureLimitExternalApiHyperflexFeatureLimitExternalsMoidDelete {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $true)]
        [String]
        ${moid}
    )

    Process {
        'Calling method: HyperflexFeatureLimitExternalApi-HyperflexFeatureLimitExternalsMoidDelete' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $Script:HyperflexFeatureLimitExternalApi.HyperflexFeatureLimitExternalsMoidDelete(
            ${moid}
        )
    }
}

function Invoke-HyperflexFeatureLimitExternalApiHyperflexFeatureLimitExternalsMoidGet {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $true)]
        [String]
        ${moid}
    )

    Process {
        'Calling method: HyperflexFeatureLimitExternalApi-HyperflexFeatureLimitExternalsMoidGet' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $Script:HyperflexFeatureLimitExternalApi.HyperflexFeatureLimitExternalsMoidGet(
            ${moid}
        )
    }
}

function Invoke-HyperflexFeatureLimitExternalApiHyperflexFeatureLimitExternalsMoidPatch {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $true)]
        [String]
        ${moid},
        [Parameter(Position = 1, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $true)]
        [intersight.Model.HyperflexFeatureLimitExternal]
        ${body}
    )

    Process {
        'Calling method: HyperflexFeatureLimitExternalApi-HyperflexFeatureLimitExternalsMoidPatch' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $Script:HyperflexFeatureLimitExternalApi.HyperflexFeatureLimitExternalsMoidPatch(
            ${moid},
            ${body}
        )
    }
}

function Invoke-HyperflexFeatureLimitExternalApiHyperflexFeatureLimitExternalsMoidPost {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $true)]
        [String]
        ${moid},
        [Parameter(Position = 1, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $true)]
        [intersight.Model.HyperflexFeatureLimitExternal]
        ${body}
    )

    Process {
        'Calling method: HyperflexFeatureLimitExternalApi-HyperflexFeatureLimitExternalsMoidPost' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $Script:HyperflexFeatureLimitExternalApi.HyperflexFeatureLimitExternalsMoidPost(
            ${moid},
            ${body}
        )
    }
}

function Invoke-HyperflexFeatureLimitExternalApiHyperflexFeatureLimitExternalsPost {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $true)]
        [intersight.Model.HyperflexFeatureLimitExternal]
        ${body}
    )

    Process {
        'Calling method: HyperflexFeatureLimitExternalApi-HyperflexFeatureLimitExternalsPost' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $Script:HyperflexFeatureLimitExternalApi.HyperflexFeatureLimitExternalsPost(
            ${body}
        )
    }
}

