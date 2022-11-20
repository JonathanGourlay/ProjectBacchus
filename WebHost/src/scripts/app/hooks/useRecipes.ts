import * as Client from "@api/client"
import { useMutation, UseMutationResult, useQuery, UseQueryResult } from "@tanstack/react-query"
import React from "react"
import appStateContainer from "./appStateContainer"

interface IUseRecipesProps {
    query: string;
}

interface IUseRecipes {
    searchRecipies: UseMutationResult<Client.Recipe[], unknown, string, unknown>;
    getRecipies: UseQueryResult<Client.Recipe[], unknown>;
}

const useRecipies = ({ query }: IUseRecipesProps): IUseRecipes => {
    const { client } = appStateContainer.useContainer();

    // TODO: make recipies a constant key 
    const getRecipies = useQuery(["Recipies", query], () => {
        if (query.length > 2) {
            return client.test_GetReciipes(query)
        }
    })
    const searchRecipies = useMutation((query: string) => { return client.test_GetReciipes(query) })

    return {
        searchRecipies,
        getRecipies
    }
}
export default useRecipies