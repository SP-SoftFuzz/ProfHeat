// Copyright 2024 SoftFuzz
//
// Licensed under the Apache License, Version 2.0 (the "License"):
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;

namespace ProfHeat.Models;

public class OptimizationResult(DateTime time, double optimizedHeat, double optimizedCosts, double co2Emissions)
{
    public DateTime Time { get; set; } = time; // The time of the optimization result
    public double OptimizedHeat { get; set; } = optimizedHeat; // Optimized heat production in MWh
    public double OptimizedCosts { get; set; } = optimizedCosts; // Optimized production costs
    public double CO2Emissions { get; set; } = co2Emissions; // CO2 emissions after optimization in kg
}
