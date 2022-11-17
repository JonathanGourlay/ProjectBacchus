import useRecipies from "hooks/useRecipes";
import React, { useState } from "react";
import { InfoCarousel } from "./InfoCarousel";
import PrettyPrintJson from "./prettyPrintJSON";
export const TodaysPlan: React.FC = () => {
    const meals = ["Breakfast", "Lunch", "Dinner", "Snack"]

    const [userInput, setUserInput] = React.useState("");

    const meals2 = useRecipies({
        query: userInput
    })

    return (
        <>
            <input value={userInput} onChange={(event) => {
                setUserInput(event.target.value);
            }} />

            {meals2.isLoading && <div><h1>Is loading!!!</h1></div>}

            <PrettyPrintJson data={meals2.data} />
            <div className="overflow-x-auto">
                {/* Put this part before </body> tag */}
                <input type="checkbox" id="my-modal-4" className="modal-toggle" />
                <label htmlFor="my-modal-4" className="modal cursor-pointer">
                    <label className="modal-box relative" htmlFor="">
                        <h3 className="text-lg font-bold">Welcome to Recipes</h3>
                        <p className="py-4">You've been selected for a chance to get one year of subscription to use Wikipedia for free!</p>
                        <p className="py-4">You've been selected for a chance to get one year of subscription to use Wikipedia for free!</p>
                        <p className="py-4">You've been selected for a chance to get one year of subscription to use Wikipedia for free!</p>
                        <p className="py-4">You've been selected for a chance to get one year of subscription to use Wikipedia for free!</p>
                        <p className="py-4">You've been selected for a chance to get one year of subscription to use Wikipedia for free!</p>
                        <p className="py-4">You've been selected for a chance to get one year of subscription to use Wikipedia for free!</p>
                    </label>
                </label>
                <table className="table table-zebra w-full">
                    {meals.map((meal, i) => {
                        {/* <!-- Card --> */ }
                        return (
                            <th>
                                <div className="card w-96 glass">
                                    <figure><img src="https://placeimg.com/400/225/arch" alt="car!" /></figure>
                                    <div className="card-body">
                                        <h2 className="card-title">{meal}</h2>
                                        <p>How to park your car at your garage?</p>
                                        <div className="card-actions justify-end">
                                            <div tabIndex={0} className="collapse collapse-arrow  border border-base-300 bg-base-100 rounded-box w-full max-w-xs">
                                                <div className="collapse-title text-xl font-medium">
                                                    Ingredients:
                                                </div>
                                                <div className="collapse-content">
                                                    <p>Ingredient</p>
                                                    <p>Ingredient1</p>
                                                    <p>Ingredients2</p>
                                                    <p>Ingredients3</p>
                                                </div>
                                            </div>

                                            <div tabIndex={0} className="collapse collapse-arrow  border border-base-300 bg-base-100 rounded-box w-full max-w-xs">
                                                <div className="collapse-title text-xl font-medium">
                                                    Nutrients:
                                                </div>
                                                <div className="collapse-content">
                                                    <p>Nutrient1</p>
                                                    <p>Nutrients2</p>
                                                    <p>Nutrients3</p>
                                                    <p>Nutrients4</p>
                                                </div>
                                            </div>

                                            <div className="badge badge-secondary badge-outline">Label1 </div>

                                            {/* The button to open modal */}
                                            <label htmlFor="my-modal-4" className="btn glass">To Recipie</label>
                                        </div>
                                    </div>
                                </div>
                            </th>
                        )
                    })}
                </table >
            </div >

            <InfoCarousel />
        </>
    );
};
