using Destiny.Models; 

namespace Destiny.Queries
{
    public static class ManifestQueries 
    {
        private const string EXOTIC_ARMOR_QUERY = 
        @"
                SELECT DISTINCT
                    json_extract(DestinyInventoryItemDefinition.json, '$.hash') as hash,
                    json_extract(DestinyInventoryItemDefinition.json, '$.displayProperties.name') as name,
                    json_extract(DestinyInventoryItemDefinition.json, '$.displayProperties.icon') as icon,
                    json_extract(DestinyInventoryItemDefinition.json, '$.loreHash') as loreHash,
                    json_extract(DestinyLoreDefinition.json, '$.displayProperties.description') as lore
                FROM 
                    DestinyInventoryItemDefinition, json_tree(DestinyInventoryItemDefinition.json, '$')
                JOIN
                    DestinyLoreDefinition
                ON
                    json_extract(DestinyInventoryItemDefinition.json, '$.loreHash') = json_extract(DestinyLoreDefinition.json, '$.hash') 
                WHERE 
                    (json_extract(DestinyInventoryItemDefinition.json, '$.summaryItemHash') = 715326750 )";
            
        private const string CLASS_CONDITION = 
        @" 
        AND (json_extract(DestinyInventoryItemDefinition.json, '$.classType') = {0} )";


        public static string GetExoticArmor()
        {
            return EXOTIC_ARMOR_QUERY; 
        }
        public static string GetExoticArmor(Classes _class) 
        {
            int classIndex = ((int)_class);                                                     //Make sure enum matches Bungie, or change casting here
            string query = String.Format(EXOTIC_ARMOR_QUERY + CLASS_CONDITION, classIndex);
            return query; 
        }
    }
}