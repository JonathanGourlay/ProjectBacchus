import { Client } from "@api/client"
import { useQuery } from "@tanstack/react-query"
import React from "react"
import appStateContainer from "./appStateContainer"

interface IUseRecipes {
    query: string;
}

const useRecipies = ({ query }: IUseRecipes) => {
    const { client } = appStateContainer.useContainer();

    // TODO: make recipies a constant key 
    const getRecipies = useQuery(["Recipies", query], () => {
        if (query.length > 2) {
            return client.test_GetReciipes(query)
        }
    })

    return getRecipies
}
export default useRecipies