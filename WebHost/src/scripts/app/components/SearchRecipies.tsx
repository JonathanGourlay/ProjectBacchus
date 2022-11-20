import useRecipies from "hooks/useRecipes";
import React, { useState } from "react";
import { useForm } from "react-hook-form";
import { InfoCarousel } from "./InfoCarousel";
import { MealCard } from "./MealCard";
import PrettyPrintJson from "./prettyPrintJSON";

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
                <input {...register("search")} />

                <button className="btn" type="submit">Button</button>
            </form>
            <div className="carousel w-full">
                <div id={'slide1'} className="carousel-item relative w-auto">
                    {meals2.searchRecipies.data ? meals2.searchRecipies.data.map(({ recipie, images }, index) => {
                        return (<>
                            <MealCard title={recipie.recipe.label} totalNutrients={recipie.recipe.totalNutrients}
                                labels={recipie.recipe.dietLabels} ingredientLines={recipie.recipe.ingredientLines} calories={recipie.recipe.calories}
                                cusine={recipie.recipe.cuisineType} image={images} />
                        </>)
                    }) : ""}
                    <div className="absolute flex justify-between transform -translate-y-1/2 left-5 right-5 top-1/2">
                        <a href={'#slide1'} className="btn btn-circle">❮</a>
                        <a href={'#slide2'} className="btn btn-circle">❯</a>
                    </div>

                </div>
            </div>
            {/* <PrettyPrintJson data={meals2.searchRecipies.data} /> */}


        </>
    );
};
