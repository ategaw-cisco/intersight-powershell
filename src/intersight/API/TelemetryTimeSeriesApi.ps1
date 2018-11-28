function Invoke-TelemetryTimeSeriesApiTelemetryTimeSeriesPost {
    [CmdletBinding()]
    Param (
        [Parameter(Position = 0, ValueFromPipeline = $true, ValueFromPipelineByPropertyName = $true, Mandatory = $true)]
        [intersight.Model.TelemetryTimeSeries]
        ${body}
    )

    Process {
        'Calling method: TelemetryTimeSeriesApi-TelemetryTimeSeriesPost' | Write-Verbose
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $Script:TelemetryTimeSeriesApi.TelemetryTimeSeriesPost(
            ${body}
        )
    }
}

