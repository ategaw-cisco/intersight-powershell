function Invoke-WorkflowWorkflowInfoApiWorkflowWorkflowInfosGet {
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
        'Calling method: WorkflowWorkflowInfoApi-WorkflowWorkflowInfosGet' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $Script:WorkflowWorkflowInfoApi.WorkflowWorkflowInfosGet(
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

function Invoke-WorkflowWorkflowInfoApiWorkflowWorkflowInfosMoidDelete {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $true)]
        [String]
        ${moid}
    )

    Process {
        'Calling method: WorkflowWorkflowInfoApi-WorkflowWorkflowInfosMoidDelete' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $Script:WorkflowWorkflowInfoApi.WorkflowWorkflowInfosMoidDelete(
            ${moid}
        )
    }
}

function Invoke-WorkflowWorkflowInfoApiWorkflowWorkflowInfosMoidGet {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $true)]
        [String]
        ${moid}
    )

    Process {
        'Calling method: WorkflowWorkflowInfoApi-WorkflowWorkflowInfosMoidGet' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $Script:WorkflowWorkflowInfoApi.WorkflowWorkflowInfosMoidGet(
            ${moid}
        )
    }
}

function Invoke-WorkflowWorkflowInfoApiWorkflowWorkflowInfosMoidPatch {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $true)]
        [String]
        ${moid},
        [Parameter(Position = 1, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $true)]
        [intersight.Model.WorkflowWorkflowInfo]
        ${body}
    )

    Process {
        'Calling method: WorkflowWorkflowInfoApi-WorkflowWorkflowInfosMoidPatch' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $Script:WorkflowWorkflowInfoApi.WorkflowWorkflowInfosMoidPatch(
            ${moid},
            ${body}
        )
    }
}

function Invoke-WorkflowWorkflowInfoApiWorkflowWorkflowInfosMoidPost {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $true)]
        [String]
        ${moid},
        [Parameter(Position = 1, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $true)]
        [intersight.Model.WorkflowWorkflowInfo]
        ${body}
    )

    Process {
        'Calling method: WorkflowWorkflowInfoApi-WorkflowWorkflowInfosMoidPost' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $Script:WorkflowWorkflowInfoApi.WorkflowWorkflowInfosMoidPost(
            ${moid},
            ${body}
        )
    }
}

function Invoke-WorkflowWorkflowInfoApiWorkflowWorkflowInfosPost {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $true)]
        [intersight.Model.WorkflowWorkflowInfo]
        ${body}
    )

    Process {
        'Calling method: WorkflowWorkflowInfoApi-WorkflowWorkflowInfosPost' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $Script:WorkflowWorkflowInfoApi.WorkflowWorkflowInfosPost(
            ${body}
        )
    }
}

