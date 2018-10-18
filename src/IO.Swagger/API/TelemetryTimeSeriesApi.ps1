function Invoke-TelemetryTimeSeriesApiTelemetryTimeSeriesPost {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $true)]
        [intersight.Model.TelemetryTimeSeries]
        ${body},
        [Parameter(Position = 1, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $true)]
        [intersight.Model.TelemetryTimeSeries]
        ${body2},
        [Parameter(Position = 2, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $true)]
        [intersight.Model.TelemetryTimeSeries]
        ${body3},
        [Parameter(Position = 3, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $true)]
        [intersight.Model.TelemetryTimeSeries]
        ${body4},
        [Parameter(Position = 4, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $true)]
        [intersight.Model.TelemetryTimeSeries]
        ${body5},
        [Parameter(Position = 5, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $true)]
        [intersight.Model.TelemetryTimeSeries]
        ${body6},
        [Parameter(Position = 6, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $true)]
        [intersight.Model.TelemetryTimeSeries]
        ${body7},
        [Parameter(Position = 7, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $true)]
        [intersight.Model.TelemetryTimeSeries]
        ${body8},
        [Parameter(Position = 8, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $true)]
        [intersight.Model.TelemetryTimeSeries]
        ${body9}
    )

    Process {
        'Calling method: TelemetryTimeSeriesApi-TelemetryTimeSeriesPost' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $Script:TelemetryTimeSeriesApi.TelemetryTimeSeriesPost(
            ${body},
            ${body2},
            ${body3},
            ${body4},
            ${body5},
            ${body6},
            ${body7},
            ${body8},
            ${body9}
        )
    }
}

