
using System;

public class Rootobject
{
    public Data data { get; set; }
    public string id { get; set; }
    public Meta meta { get; set; }
    public object[] errors { get; set; }
    public object[] warnings { get; set; }
}

public class Data
{
    public DateTime lastUpdate { get; set; }
    public Scopequalifier scopeQualifier { get; set; }
    public Securityqualifier securityQualifier { get; set; }
    public Originqualifier originQualifier { get; set; }
    public Behaviorqualifier[] behaviorQualifier { get; set; }
    public Behavior[] behaviors { get; set; }
    public Keyqualifier[] keyQualifier { get; set; }
    public Term[] terms { get; set; }
}

public class Scopequalifier
{
    public string qualifierId { get; set; }
    public string displayText { get; set; }
    public string description { get; set; }
    public Keyqualifiervalue[] keyQualifierValues { get; set; }
}

public class Keyqualifiervalue
{
    public string value { get; set; }
    public string displayText { get; set; }
    public string description { get; set; }
}

public class Securityqualifier
{
    public string qualifierId { get; set; }
    public string displayText { get; set; }
    public string description { get; set; }
    public Keyqualifiervalue1[] keyQualifierValues { get; set; }
}

public class Keyqualifiervalue1
{
    public string value { get; set; }
    public string displayText { get; set; }
    public string description { get; set; }
}

public class Originqualifier
{
    public string qualifierId { get; set; }
    public string displayText { get; set; }
    public string description { get; set; }
    public Keyqualifiervalue2[] keyQualifierValues { get; set; }
}

public class Keyqualifiervalue2
{
    public string value { get; set; }
    public string displayText { get; set; }
    public string description { get; set; }
}

public class Behaviorqualifier
{
    public string qualifierId { get; set; }
    public string displayText { get; set; }
    public string description { get; set; }
    public Behavioraction[] behaviorActions { get; set; }
    public Behaviorterm[] behaviorTerms { get; set; }
}

public class Behavioraction
{
    public string action { get; set; }
    public string type { get; set; }
    public string displayText { get; set; }
    public string description { get; set; }
    public Behavioractionvalue[] behaviorActionValues { get; set; }
}

public class Behavioractionvalue
{
    public string value { get; set; }
    public string listOrder { get; set; }
    public string displayText { get; set; }
    public string description { get; set; }
}

public class Behaviorterm
{
    public string cbIndex { get; set; }
    public string dataType { get; set; }
    public string description { get; set; }
    public string displayText { get; set; }
    public string isActive { get; set; }
    public string isDerived { get; set; }
    public string isEditable { get; set; }
    public string isEquity { get; set; }
    public string isMutualFund { get; set; }
    public string termId { get; set; }
    public Termvalue[] termValues { get; set; }
    public string source { get; set; }
    public string copybookName { get; set; }
    public string databaseField { get; set; }
    public string databaseName { get; set; }
    public string derivedDetails { get; set; }
    public string factTermIDs { get; set; }
    public string maxLength { get; set; }
    public string maxValue { get; set; }
    public string minValue { get; set; }
    public string notWithinTermIDs { get; set; }
    public string precision { get; set; }
    public string factListLabels { get; set; }
    public string[] factLists { get; set; }
    public string[] factTermIDsList { get; set; }
    public string[] notWithinTermIDsList { get; set; }
}

public class Termvalue
{
    public string value { get; set; }
    public string displayText { get; set; }
    public string description { get; set; }
}

public class Behavior
{
    public string qualifierId { get; set; }
    public string displayText { get; set; }
}

public class Keyqualifier
{
    public string qualifierId { get; set; }
    public string displayText { get; set; }
    public string description { get; set; }
    public Keyqualifiervalue3[] keyQualifierValues { get; set; }
    public Behavioraction1[] behaviorActions { get; set; }
    public Behaviorterm1[] behaviorTerms { get; set; }
}

public class Keyqualifiervalue3
{
    public string value { get; set; }
    public string displayText { get; set; }
    public string description { get; set; }
}

public class Behavioraction1
{
    public string action { get; set; }
    public string type { get; set; }
    public string displayText { get; set; }
    public string description { get; set; }
    public Behavioractionvalue1[] behaviorActionValues { get; set; }
}

public class Behavioractionvalue1
{
    public string value { get; set; }
    public string listOrder { get; set; }
    public string displayText { get; set; }
    public string description { get; set; }
}

public class Behaviorterm1
{
    public string cbIndex { get; set; }
    public string dataType { get; set; }
    public string description { get; set; }
    public string displayText { get; set; }
    public string isActive { get; set; }
    public string isDerived { get; set; }
    public string isEditable { get; set; }
    public string isEquity { get; set; }
    public string isMutualFund { get; set; }
    public string termId { get; set; }
    public Termvalue1[] termValues { get; set; }
    public string source { get; set; }
    public string copybookName { get; set; }
    public string databaseField { get; set; }
    public string databaseName { get; set; }
    public string derivedDetails { get; set; }
    public string factTermIDs { get; set; }
    public string maxLength { get; set; }
    public string maxValue { get; set; }
    public string minValue { get; set; }
    public string notWithinTermIDs { get; set; }
    public string precision { get; set; }
    public string factListLabels { get; set; }
    public string[] factLists { get; set; }
    public string[] factTermIDsList { get; set; }
    public string[] notWithinTermIDsList { get; set; }
}

public class Termvalue1
{
    public string value { get; set; }
    public string displayText { get; set; }
    public string description { get; set; }
}

public class Term
{
    public string cbIndex { get; set; }
    public string dataType { get; set; }
    public string description { get; set; }
    public string displayText { get; set; }
    public string isActive { get; set; }
    public string isDerived { get; set; }
    public string isEditable { get; set; }
    public string isEquity { get; set; }
    public string isMutualFund { get; set; }
    public string source { get; set; }
    public string termId { get; set; }
    public Termvalue2[] termValues { get; set; }
    public string copybookName { get; set; }
    public string databaseField { get; set; }
    public string databaseName { get; set; }
    public string derivedDetails { get; set; }
    public string factTermIDs { get; set; }
    public string maxLength { get; set; }
    public string maxValue { get; set; }
    public string minValue { get; set; }
    public string notWithinTermIDs { get; set; }
    public string precision { get; set; }
    public string factListLabels { get; set; }
    public string[] factLists { get; set; }
    public string[] factTermIDsList { get; set; }
    public string[] notWithinTermIDsList { get; set; }
}

public class Termvalue2
{
    public string value { get; set; }
    public string displayText { get; set; }
    public string description { get; set; }
}

public class Meta
{
    public string recordCount { get; set; }
}
