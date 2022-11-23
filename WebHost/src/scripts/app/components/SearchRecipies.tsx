import useRecipies from "hooks/useRecipes";
import React, { useState } from "react";
import { useForm } from "react-hook-form";
import { InfoCarousel } from "./InfoCarousel";
import { MealCard } from "./MealCard";
import PrettyPrintJson from "./prettyPrintJSON";
import WrapIf from "./WrapIf";

type SearchBarForm = {
    search: string;
}

export const SearchRecipies: React.FC = () => {

    const { register, handleSubmit } = useForm<SearchBarForm>();
    const [userInput, setUserInput] = React.useState("");


    const meals2 = useRecipies({
        query: userInput
    })

    const submit = handleSubmit((isValid) => {
        meals2.searchRecipies.mutate(isValid.search, {
            onSuccess: (data) => console.log(data)
        })
    })

    return (
        <>
            <form onSubmit={submit}>
                <div className="p-5 bg-neutral">
                    <input {...register("search")} className="input input-bordered w-full max-w-xs" placeholder={"Search"} />
                    <button type="submit">
                        <label tabIndex={0} className="btn btn-ghost btn-circle" >
                            <svg xmlns="http://www.w3.org/2000/svg" className="h-5 w-5" fill="none" viewBox="0 0 24 24" stroke="currentColor"><path strokeLinecap="round" strokeLinejoin="round" strokeWidth="2" d="M21 21l-6-6m2-5a7 7 0 11-14 0 7 7 0 0114 0z" /></svg>
                        </label>
                    </button>
                </div>
            </form>
            <div className="carousel w-200 p-5">
                {meals2.searchRecipies.data ? meals2.searchRecipies.data.map(({ recipie, images }, index) => {
                    return (
                        <>
                            <MealCard title={recipie.recipe.label} nutrients={recipie.recipe.nutrients}
                                labels={recipie.recipe.dietLabels} ingredientLines={recipie.recipe.ingredientLines} calories={recipie.recipe.calories}
                                cusine={recipie.recipe.cuisineType} image={images} shareAs={recipie.recipe.yield} />
                            <div className="m-5" />
                        </>)
                }) : ""}


            </div>


        </>
    );
};
