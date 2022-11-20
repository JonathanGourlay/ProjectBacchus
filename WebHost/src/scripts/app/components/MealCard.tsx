import { TotalNutrients } from "@api/client";
import useRecipies from "hooks/useRecipes";
import React, { useState } from "react";
import { InfoCarousel } from "./InfoCarousel";
import PrettyPrintJson from "./prettyPrintJSON";

interface IMealCard {
    title: string;
    totalNutrients?: TotalNutrients;
    labels: string[];
    ingredientLines: string[];
    calories: number;
    cusine: string[];
    image: string;
}

export const MealCard = (props: IMealCard) => {

    return (
        <>
            <th>
                <div className="card w-96 glass">
                    <figure><div className="avatar">
                        <div className="w-50 m-8  rounded-full shadow-2xl">
                            <img src={props.image} alt="car!" />
                        </div>
                    </div>
                    </figure>
                    <div className="card-body">
                        <h2 className="card-title">{props.title}</h2>
                        <div className="card-actions justify-end">
                            <div tabIndex={0} className="collapse collapse-arrow  border border-base-300 bg-base-100 rounded-box w-full max-w-xs">
                                <div className="collapse-title text-xl font-medium">
                                    Ingredients:
                                </div>
                                <div className="collapse-content">
                                    {props.ingredientLines.map((ing) => { return <p>{ing}</p> })}
                                </div>
                            </div>

                            <div tabIndex={0} className="collapse collapse-arrow  border border-base-300 bg-base-100 rounded-box w-full max-w-xs">
                                <div className="collapse-title text-xl font-medium">
                                    Nutrients:
                                </div>
                                <div className="collapse-content">
                                    {/* {Object.entries(props.totalNutrients).map(() => { return <> <p>{ing}: </p><p>{value} </p> </> })} */}
                                </div>
                            </div>
                            {props.labels.map((ing) => { return <div className="badge badge-secondary badge-outline">{ing} </div> })}

                            {/* The button to open modal */}
                            <label htmlFor="my-modal-4" className="btn glass">To Recipie</label>
                        </div>
                    </div>
                </div>
            </th>
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
        </>
    );
};
