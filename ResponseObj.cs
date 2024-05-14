using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class amortizationschedule
{
    [JsonProperty("month")]
    public int month { get; set; }

    [JsonProperty("interest_payment")]
    public double interestpayment { get; set; }

    [JsonProperty("principal_payment")]
    public double principalpayment { get; set; }

    [JsonProperty("remaining_balance")]
    public double remainingbalance { get; set; }

}

public class data
{
    [JsonProperty("loanAmount")]
    public int loanAmount { get; set; }

    [JsonProperty("downpayment")]
    public int downpayment { get; set; }

    [JsonProperty("interestRate")]
    public double interestRate { get; set; }

    [JsonProperty("loanTerm")]
    public int loanTerm { get; set; }

    [JsonProperty("monthly_payment")]
    public double monthlypayment { get; set; }

    [JsonProperty("total_interest_paid")]
    public double totalinterestpaid { get; set; }

    [JsonProperty("amortization_schedule")]
    public amortizationschedule[] amortizationschedule { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

}

}
